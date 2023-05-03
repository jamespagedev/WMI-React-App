import React from "react";

export default function TableSpinner({ columnNames, numOfRows }) {
  const getTdRows = () => {
    const rows = [];
    for (let i = 0; i < numOfRows; i++) {
      rows.push(
        <tr key={i}>
          {columnNames.map((cn, i) => (
            <td key={`${cn}-${i}`}>
              <div className="table-spinner" />
            </td>
          ))}
        </tr>
      );
    }
    return rows;
  };
  return (
    <table className="m-auto">
      <thead>
        <tr>
          {columnNames.map((cn) => (
            <th key={cn}>{cn}</th>
          ))}
        </tr>
      </thead>
      <tbody>{getTdRows()}</tbody>
    </table>
  );
}
