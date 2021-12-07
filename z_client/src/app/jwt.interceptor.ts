import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Authorizeservice } from './Nav/Authorize.service';
import { take } from 'rxjs/operators';
import { Usertoken } from './Nav/User';

@Injectable()
export class JwtInterceptor implements HttpInterceptor {

  constructor(private userserv:Authorizeservice) {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {

    let currentUser!:Usertoken;
    this.userserv.currentuser$.pipe(take(1)).subscribe(user=>currentUser=user);
    if(currentUser){
      request=request.clone({
        setHeaders:{
          Authorization:`Bearer ${currentUser.token}`
        }
      })
    }
    return next.handle(request);
  }
}
