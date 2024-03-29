
const yourIP = 'Your Local IP Address etc 192.168.1.64'; // See the docs https://docs.abp.io/en/abp/latest/Getting-Started-React-Native?Tiered=No
const port  = 44305;
const apiUrl = `http://${yourIP}:${port}`;
const ENV = {
  dev: {
    apiUrl: apiUrl,
    oAuthConfig: {
      issuer: apiUrl,
      clientId: 'Human_App',
      scope: 'offline_access Human',
    },
    localization: {
      defaultResourceName: 'Human',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44361',
    oAuthConfig: {
      issuer: 'http://localhost:44361',
      clientId: 'Human_App',
      scope: 'offline_access Human',
    },
    localization: {
      defaultResourceName: 'Human',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
