import React from "react";
import { Dropdown, Search } from "../../components";

export default function TableSubHeader({
  searchValue,
  handleSearch,
  country,
  selectCountry,
  availableCountries,
}) {
  return (
    <div>
      <div style={{ height: "82px" }} />
      <div className="tbl-sub-header">
        <div className="tbl-sub-header-container">
          <Search value={searchValue} handleSearch={handleSearch} />
          <div className="d-flex d-justify-center d-align-center">
            <h2>Filter&nbsp;Countries&nbsp;By:&nbsp;</h2>
            <Dropdown
              selectedValue={country}
              handleSelectValue={selectCountry}
              list={availableCountries}
            />
          </div>
        </div>
      </div>
    </div>
  );
}
