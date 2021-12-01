import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root',
})
export class HttpService {
  server = environment.api;

  constructor(private httpClient: HttpClient) {}

  getRequest = <T>(options: Options) => {
    const api = `${this.server}/${options.url}`;
    return this.httpClient.get<T>(api, {
      params: options.body,
    });
  };
}

type Options = {
  url: string;
  body?: any;
  token?: string;
};
