import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'HomeExpenses',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44393/',
    redirectUri: baseUrl,
    clientId: 'HomeExpenses_App',
    responseType: 'code',
    scope: 'offline_access HomeExpenses',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44326',
      rootNamespace: 'AI.HomeExpenses',
    },
  },
} as Environment;
