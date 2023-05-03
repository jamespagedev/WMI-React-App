import React, { useEffect, useState } from "react";
import {
  apiGetRequest,
  backendEndpoints,
  getStrDateFormatYyyyMmDdWithDashes,
  sleep,
} from "./utils";
import { Header, Table, View } from "./components";
import TableSpinner from "./components/spinners/TableSpinner";

// static variables
const columnNames = ["Name", "WMI", "Country", "CreatedOn", "VehicleType"];
const columnNamesToDataKeys = {
  Name: "name",
  WMI: "wmi",
  Country: "country",
  CreatedOn: "createdOn",
  VehicleType: "vehicleType",
};

function App() {
  // variables
  const [isLoadingCars, setIsLoadingCars] = useState(false);
  const [carsData, setCarsData] = useState([]);

  // functions
  async function initDisp() {
    try {
      // show spinners
      setIsLoadingCars(true);
      // used to fake long response to api and show spinner
      await sleep(2000);
      // get data
      const carsRes = await apiGetRequest(backendEndpoints.cars, {});
      // logic
      const carsResData = carsRes.data.map((c) => {
        c[columnNamesToDataKeys.CreatedOn] = getStrDateFormatYyyyMmDdWithDashes(
          new Date(`${c[columnNamesToDataKeys.CreatedOn]}z`)
        );
        return c;
      });
      // set data
      setCarsData(carsResData);
    } catch (err) {
      console.log("api err:", err);
    } finally {
      // render table
      setIsLoadingCars(false);
    }
  }

  // setup
  useEffect(() => {
    initDisp();
  }, []);

  return (
    <div className="App">
      <Header isLoading={isLoadingCars} numOfTableRows={carsData.length} />
      <View>
        {isLoadingCars ? (
          <TableSpinner columnNames={columnNames} numOfRows={20} />
        ) : (
          <Table
            columnNames={columnNames}
            rowsData={carsData}
            columnNamesToDataKeys={columnNamesToDataKeys}
          />
        )}
      </View>
    </div>
  );
}

export default App;
