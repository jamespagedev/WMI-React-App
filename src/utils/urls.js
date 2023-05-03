export const backendServerUrl =
  process.env.NODE_ENV === "development"
    ? process.env.REACT_APP_DEV_API
    : process.env.NODE_ENV === "test"
    ? process.env.REACT_APP_TEST_API
    : process.env.REACT_APP_PROD_API; // prod

export const frontendPaths = {
  landing: "/",
};

export const backendEndpoints = {
  cars: "/Cars",
};
