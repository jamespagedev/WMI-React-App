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

// helper functions
function getFormatTableDate(data) {
  const formattedData = data.map((c) => {
    c[columnNamesToDataKeys.CreatedOn] = getStrDateFormatYyyyMmDdWithDashes(
      new Date(`${c[columnNamesToDataKeys.CreatedOn]}z`)
    );
    return c;
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
      // get data
      const carsRes = await apiGetRequest(backendEndpoints.cars, {});
      // set data
      setCarsData(getFormatTableDate(carsRes.data));
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
        `${backendEndpoints.cars}/search?searchValue=${searchCarsValue}`,
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
        isLoading={isUpdatingData}
        searchValue={searchCarsValue}
        handleSearch={handleSearch}
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
