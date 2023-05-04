import React from "react";
import { Search } from "../../components";

export default function TableSubHeader({
  isLoading,
  searchValue,
  handleSearch,
}) {
  return (
    <div>
      <div style={{ height: "82px" }} />
      <div className="tbl-sub-header">
        <Search
          isLoading={isLoading}
          value={searchValue}
          handleSearch={handleSearch}
        />
      </div>
    </div>
  );
}
