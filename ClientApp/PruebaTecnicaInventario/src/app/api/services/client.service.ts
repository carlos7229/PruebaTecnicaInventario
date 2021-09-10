/* tslint:disable */
/* eslint-disable */
import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { BaseService } from '../base-service';
import { ApiConfiguration } from '../api-configuration';
import { StrictHttpResponse } from '../strict-http-response';
import { RequestBuilder } from '../request-builder';
import { Observable } from 'rxjs';
import { map, filter } from 'rxjs/operators';

import { Client } from '../models/client';

@Injectable({
  providedIn: 'root',
})
export class ClientService extends BaseService {
  constructor(
    config: ApiConfiguration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Path part for operation apiClientGet
   */
  static readonly ApiClientGetPath = '/api/Client';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiClientGet()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiClientGet$Response(params?: {
  }): Observable<StrictHttpResponse<any>> {

    const rb = new RequestBuilder(this.rootUrl, ClientService.ApiClientGetPath, 'get');
    if (params) {
    }

    return this.http.request(rb.build({
      responseType: 'text',
      accept: '*/*'
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return (r as HttpResponse<any>).clone({ body: undefined }) as StrictHttpResponse<any>;
      })
    );
  }

  /**
   * This method provides access to only to the response body.
   * To access the full response (for headers, for example), `apiClientGet$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiClientGet(params?: {
  }): Observable<any> {

    return this.apiClientGet$Response(params).pipe(
      map((r: StrictHttpResponse<any>) => r.body as any)
    );
  }

  /**
   * Path part for operation apiClientPut
   */
  static readonly ApiClientPutPath = '/api/Client';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiClientPut()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiClientPut$Response(params?: {
    body?: Client
  }): Observable<StrictHttpResponse<void>> {

    const rb = new RequestBuilder(this.rootUrl, ClientService.ApiClientPutPath, 'put');
    if (params) {
      rb.body(params.body, 'application/*+json');
    }

    return this.http.request(rb.build({
      responseType: 'text',
      accept: '*/*'
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return (r as HttpResponse<any>).clone({ body: undefined }) as StrictHttpResponse<void>;
      })
    );
  }

  /**
   * This method provides access to only to the response body.
   * To access the full response (for headers, for example), `apiClientPut$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiClientPut(params?: {
    body?: Client
  }): Observable<void> {

    return this.apiClientPut$Response(params).pipe(
      map((r: StrictHttpResponse<void>) => r.body as void)
    );
  }

  /**
   * Path part for operation apiClientPost
   */
  static readonly ApiClientPostPath = '/api/Client';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiClientPost()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiClientPost$Response(params?: {
    body?: Client
  }): Observable<StrictHttpResponse<void>> {

    const rb = new RequestBuilder(this.rootUrl, ClientService.ApiClientPostPath, 'post');
    if (params) {
      rb.body(params.body, 'application/*+json');
    }

    return this.http.request(rb.build({
      responseType: 'text',
      accept: '*/*'
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return (r as HttpResponse<any>).clone({ body: undefined }) as StrictHttpResponse<void>;
      })
    );
  }

  /**
   * This method provides access to only to the response body.
   * To access the full response (for headers, for example), `apiClientPost$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiClientPost(params?: {
    body?: Client
  }): Observable<void> {

    return this.apiClientPost$Response(params).pipe(
      map((r: StrictHttpResponse<void>) => r.body as void)
    );
  }


  /**
   * Path part for operation apiClientDelete
   */
   static readonly ApiClientDeletePath = '/api/Client';

   /**
    * This method provides access to the full `HttpResponse`, allowing access to response headers.
    * To access only the response body, use `apiClientDelete()` instead.
    *
    * This method doesn't expect any request body.
    */
   apiClientDelete$Response(params?: {
     id?: number;
   }): Observable<StrictHttpResponse<void>> {
 
     const rb = new RequestBuilder(this.rootUrl, ClientService.ApiClientDeletePath, 'delete');
     if (params) {
       rb.query('id', params.id, {});
     }
 
     return this.http.request(rb.build({
       responseType: 'text',
       accept: '*/*'
     })).pipe(
       filter((r: any) => r instanceof HttpResponse),
       map((r: HttpResponse<any>) => {
         return (r as HttpResponse<any>).clone({ body: undefined }) as StrictHttpResponse<void>;
       })
     );
   }
 
   /**
    * This method provides access to only to the response body.
    * To access the full response (for headers, for example), `apiClientDelete$Response()` instead.
    *
    * This method doesn't expect any request body.
    */
   apiClientDelete(params?: {
     id?: number;
   }): Observable<void> {
 
     return this.apiClientDelete$Response(params).pipe(
       map((r: StrictHttpResponse<void>) => r.body as void)
     );
   }



  /**
   * Path part for operation apiClientIdGet
   */
  static readonly ApiClientIdGetPath = '/api/Client/{id}';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiClientIdGet()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiClientIdGet$Response(params: {
    id: number;
  }): Observable<StrictHttpResponse<any>> {

    const rb = new RequestBuilder(this.rootUrl, ClientService.ApiClientIdGetPath, 'get');
    if (params) {
      rb.path('id', params.id, {});
    }

    return this.http.request(rb.build({
      responseType: 'text',
      accept: '*/*'
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return (r as HttpResponse<any>).clone({ body: undefined }) as StrictHttpResponse<any>;
      })
    );
  }

  /**
   * This method provides access to only to the response body.
   * To access the full response (for headers, for example), `apiClientIdGet$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiClientIdGet(params: {
    id: number;
  }): Observable<any> {

    return this.apiClientIdGet$Response(params).pipe(
      map((r: StrictHttpResponse<any>) => r.body as any)
    );
  }

}
