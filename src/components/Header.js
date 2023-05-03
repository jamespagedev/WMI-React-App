import React from "react";
import HeaderSpinner from "./spinners/HeaderSpinner";

export default function Header({ isLoading, numOfTableRows }) {
  return (
    <div className="header-placeholder">
      <header>
        {/* ToDo: setup event listener to get accurate heights for different render screens and browsers */}

        <h2 className="header-h2">
          WMI Data - Honda | Total:{" "}
          {isLoading ? <HeaderSpinner /> : numOfTableRows}
        </h2>
      </header>
    </div>
  );
}
