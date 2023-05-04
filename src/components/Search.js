import React from "react";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faSearch } from "@fortawesome/fontawesome-free-solid";

export default function Search({ value, handleSearch }) {
  return (
    <div className="search-container">
      <div className="left">
        <input
          type="search"
          placeholder="Search Car"
          value={value}
          onChange={(ev) => handleSearch(ev.target.value)}
        />
      </div>
      <div className="right">
        <FontAwesomeIcon icon={faSearch} className="fa-search" />
      </div>
    </div>
  );
}
