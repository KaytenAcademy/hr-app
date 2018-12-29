const AppConsts = {
  userManagement: {
    defaultAdminUserName: 'admin',
  },
  localization: {
    defaultLocalizationSourceName: 'HR',
  },
  authorization: {
    encrptedAuthTokenName: 'enc_auth_token',
  },
  appBaseUrl: process.env.REACT_APP_APP_BASE_URL,
  remoteServiceBaseUrl: process.env.REACT_APP_REMOTE_SERVICE_BASE_URL,
};
export default AppConsts;
