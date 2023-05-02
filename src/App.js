import React from "react";
import data from "./honda_wmi.json";
import { Header, Table, View } from "./components";

function App() {
  const keys = ["Name", "WMI", "Country", "CreatedOn", "VehicleType"];

  return (
    <div className="App">
      <Header numOfTableRows={data.length} />
      <View>
        <Table columnNames={keys} rowsData={data} />
      </View>
    </div>
  );
}

export default App;
