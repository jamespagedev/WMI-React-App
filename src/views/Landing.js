import React, { useCallback, useEffect, useRef, useState } from "react";
import {
  apiGetRequest,
  backendEndpoints,
  getStrDateFormatYyyyMmDdWithDashes,
  sleep,
} from "../utils";
import { Header, Table, View } from "../components";
import { TableSubHeader } from "./children";
import TableSpinner from "../components/spinners/TableSpinner";
import debounce from "lodash.debounce";

// static variables
const columnNames = ["Name", "WMI", "Country", "CreatedOn", "VehicleType"];
const columnNamesToDataKeys = {
  Name: "name",
  WMI: "wmi",
  Country: "country",
  CreatedOn: "createdOn",
  VehicleType: "vehicleType",
};
const defaultSelectedCountry = "View All";

// helper functions
function getFormatTableDate(data) {
  const formattedData = data.map((car) => {
    car[columnNamesToDataKeys.CreatedOn] = getStrDateFormatYyyyMmDdWithDashes(
      new Date(`${car[columnNamesToDataKeys.CreatedOn]}z`)
    );
    return car;
  });
  return formattedData;
}

function getFormattedAvailableCountries(data) {
  const formattedData = [defaultSelectedCountry];
  data.forEach((country) => {
    formattedData.push(country.name);
  });
  return formattedData;
}

export default function Landing() {
  // variables
  const isDebouncingRef = useRef(false);
  const [isInitializingData, setIsInitializingData] = useState(false);
  const [isUpdatingData, setIsUpdatingData] = useState(false);
  const [carsData, setCarsData] = useState([]);
  const [searchCarsValue, setSearchCarsValue] = useState("");
  const [selectedCountry, setSelectedCountry] = useState(
    defaultSelectedCountry
  );
  const [availableCountries, setAvailableCountries] = useState([]);
  const [executeDebouncer, setExecuteDebouncer] = useState(false);
  // eslint-disable-next-line react-hooks/exhaustive-deps
  const debounceUpdateData = useCallback(
    debounce(() => setExecuteDebouncer(true), 3000),
    []
  );

  // functions
  async function initData() {
    try {
      // show spinners
      setIsInitializingData(true);
      // used to fake long response to api and show spinner
      await sleep(2000);
      // get cars data
      const carsRes = await apiGetRequest(
        `${backendEndpoints.cars}${
          selectedCountry !== defaultSelectedCountry
            ? `/search?country=${selectedCountry}`
            : ""
        }`,
        {}
      );
      // set cars data
      setCarsData(getFormatTableDate(carsRes.data));
      if (availableCountries.length === 0) {
        const countriesRes = await apiGetRequest(
          backendEndpoints.countries,
          {}
        );
        setAvailableCountries(
          getFormattedAvailableCountries(countriesRes.data)
        );
      }
    } catch (err) {
      console.log("api err:", err);
    } finally {
      // render table
      setIsInitializingData(false);
      if (!isDebouncingRef.current) {
        setIsUpdatingData(false);
      }
    }
  }

  // eslint-disable-next-line react-hooks/exhaustive-deps
  async function updateData() {
    try {
      // get data
      const carsRes = await apiGetRequest(
        `${backendEndpoints.cars}/search?${
          searchCarsValue.length > 0 ? `searchValue=${searchCarsValue}&` : ""
        }country=${selectedCountry}`,
        {}
      );
      // set data
      setCarsData(getFormatTableDate(carsRes.data));
    } catch (err) {
      console.log("api err:", err);
    } finally {
      // render table
      if (!isDebouncingRef.current) {
        setIsUpdatingData(false);
      }
    }
  }

  function handleSearch(text) {
    setIsUpdatingData(true);
    isDebouncingRef.current = true;
    setSearchCarsValue(text);
    debounceUpdateData();
  }

  function handleSelectCountry(countryName) {
    setIsUpdatingData(true);
    isDebouncingRef.current = true;
    setSelectedCountry(countryName);
    debounceUpdateData();
  }

  // setup
  useEffect(() => {
    if (searchCarsValue.length === 0) {
      initData();
    } else if (executeDebouncer && searchCarsValue.length > 0) {
      updateData();
    }
    isDebouncingRef.current = false;
    setExecuteDebouncer(false);
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [executeDebouncer]);

  return (
    <View>
      <Header
        isLoading={isInitializingData || isUpdatingData}
        numOfTableRows={carsData.length}
      />
      <TableSubHeader
        searchValue={searchCarsValue}
        handleSearch={handleSearch}
        country={selectedCountry}
        selectCountry={handleSelectCountry}
        availableCountries={availableCountries}
      />
      {isInitializingData || isUpdatingData ? (
        <TableSpinner columnNames={columnNames} numOfRows={20} />
      ) : (
        <Table
          columnNames={columnNames}
          rowsData={carsData}
          columnNamesToDataKeys={columnNamesToDataKeys}
        />
      )}
    </View>
  );
}
