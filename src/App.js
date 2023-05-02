import React from "react";
import "./App.css";
import data from "./honda_wmi.json";
import { Header, View } from "./components";

function App() {
  const keys = ["Name", "WMI", "Country", "CreatedOn", "VehicleType"];

  const getRowsJsx = () => {
    return data.map((d) => {
      const wmi = d.WMI;
      return (
        <tr key={wmi}>
          {keys.map((k) => (
            <td key={`${wmi}-${k}`}>{d[k]}</td>
          ))}
        </tr>
      );
    });
  };

  return (
    <div className="App">
      <Header numOfTableRows={data.length} />
      <View>
        <table className="m-auto">
          <thead>
            <tr>
              {keys.map((k) => (
                <th key={k}>{k}</th>
              ))}
            </tr>
          </thead>
          <tbody>{getRowsJsx()}</tbody>
        </table>
      </View>
    </div>
  );
}

export default App;
