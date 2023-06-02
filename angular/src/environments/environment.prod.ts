import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'EcommerceABP',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44354/',
    redirectUri: baseUrl,
    clientId: 'EcommerceABP_App',
    responseType: 'code',
    scope: 'offline_access EcommerceABP',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44349',
      rootNamespace: 'EcommerceABP',
    },
  },
} as Environment;
