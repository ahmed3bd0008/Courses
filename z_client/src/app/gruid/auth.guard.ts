import { error } from '@angular/compiler/src/util';
import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import{Authorizeservice}from"../Nav/Authorize.service";
import { Usertoken } from '../Nav/User';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  /**
   *
   */
  constructor(private permissions: Permissions, private  accountservic:Authorizeservice) {}
  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean | UrlTree | Observable<boolean | UrlTree> | Promise<boolean | UrlTree> {
    throw new Error('Method not implemented.');
  }

  // canActivate(
  //   route: ActivatedRouteSnapshot,
  //   state: RouterStateSnapshot
  // ): Observable<boolean|UrlTree>|Promise<boolean|UrlTree>|boolean|UrlTree {
  //   return this.permissions.canActivate(this.accountservic.currentuser$, route.params.id);
  // }

  // canActivate(
  //   route: ActivatedRouteSnapshot,
  //   state: RouterStateSnapshot
  // ): Observable<boolean|UrlTree>|Promise<boolean|UrlTree>|boolean|UrlTree|any {
  //   return this.accountservic.currentuser$.pipe(map(user=>{
  //     if(user!=null)
  //     {
  //       return true;
  //       console.log(user)
  //     }
  //   })
  //   )

  // class Permissions {
  //   canActivate(user: Observable<Usertoken>, id: string): boolean {
  //     return true;
  //   }
  }





