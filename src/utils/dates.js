export const getDayNameOfWeek = () => {
  return new Date().toLocaleDateString("en-us", { weekday: "long" });
};

export const getStrDateFormatYyyyMmDdWithDashes = (date = null) => {
  if (date === null) {
    const now = new Date();
    return `${now.getFullYear()}-${now.getMonth() > 8 ? "" : "0"}${
      now.getMonth() + 1
    }-${now.getDate() > 9 ? "" : "0"}${now.getDate()}`;
  }
  return `${date.getFullYear()}-${date.getMonth() > 8 ? "" : "0"}${
    date.getMonth() + 1
  }-${date.getDate() > 9 ? "" : "0"}${date.getDate()}`;
};
