import axios from "axios";
import { backendServerUrl } from "./urls";
const config = {
  baseURL: backendServerUrl,
  timeout: 100000,
  headers: {
    "Content-Type": "application/json",
  },
};
const requestInstance = axios.create(config);
const apiOptions = {
  headers: {
    Accept: "application/json",
    "Content-Type": "application/json",
  },
};

const getApiOptions = () => {
  const newApiOptions = new Promise((resolve, reject) => {
    resolve(apiOptions);
    reject(new Error("your api options are down."));
  });
  return newApiOptions;
};

export const apiGetRequest = (url, data) =>
  getApiOptions().then(async (options) => {
    options.params = data;
    return requestInstance.get(url, options);
  });

export const apiPostRequest = (url, data) =>
  getApiOptions().then(async (options) => {
    options.params = {};
    return requestInstance.post(url, data, options);
  });

export const apiDeleteRequest = (url, data) =>
  getApiOptions().then(async (options) => {
    options.data = data;
    options.params = {};
    return requestInstance.delete(url, options);
  });

export const apiPutRequest = (url, data) =>
  getApiOptions().then(async (options) => {
    return requestInstance.put(url, data, options);
  });

requestInstance.interceptors.request.use(async (request) => {
  return request;
});
