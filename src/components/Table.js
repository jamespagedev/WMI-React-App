import React from "react";

export default function Table({ columnNames, rowsData }) {
  return (
    <table className="m-auto">
      <thead>
        <tr>
          {columnNames.map((k) => (
            <th key={k}>{k}</th>
          ))}
        </tr>
      </thead>
      <tbody>
        {rowsData.map((d) => (
          <tr key={d.wmi}>
            {columnNames.map((k) => (
              <td key={`${d.wmi}-${k}`}>{d[k]}</td>
            ))}
          </tr>
        ))}
      </tbody>
    </table>
  );
}
