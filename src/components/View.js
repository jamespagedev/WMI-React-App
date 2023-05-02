import React from "react";

export default function View({ children }) {
  return (
    <div className="view">
      <div className="view-container">{children}</div>
    </div>
  );
}
