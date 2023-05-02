import React from "react";

export default function Header({ numOfTableRows }) {
  return (
    <div className="header-placeholder">
      <header>
        {/* ToDo: setup event listener to get accurate heights for different render screens and browsers */}

        <h2 className="header-h2">
          WMI Data - Honda | Total: {numOfTableRows}
        </h2>
      </header>
    </div>
  );
}
