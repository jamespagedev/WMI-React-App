import React from "react";

export default function Dropdown({ selectedValue, handleSelectValue, list }) {
  return (
    <select
      id={selectedValue}
      className="select-dropdown"
      value={selectedValue}
      onChange={(ev) => handleSelectValue(ev.target.value)}
    >
      {list.map((country) => (
        <option key={country} value={country}>
          {country}
        </option>
      ))}
    </select>
  );
}
