import React from "react";

export default function Table({
  columnNames,
  rowsData,
  columnNamesToDataKeys,
}) {
  return (
    <table className="m-auto">
      <thead>
        <tr>
          {columnNames.map((cn) => (
            <th key={cn}>{cn}</th>
          ))}
        </tr>
      </thead>
      <tbody>
        {rowsData.map((d) => (
          <tr key={d.id}>
            {columnNames.map((cn) => (
              <td key={`${d.wmi}-${cn}`}>{d[columnNamesToDataKeys[cn]]}</td>
            ))}
          </tr>
        ))}
      </tbody>
    </table>
  );
}
