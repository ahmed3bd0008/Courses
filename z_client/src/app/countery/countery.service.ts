import { Injectable } from "@angular/core";
import{HttpClient}from '@angular/common/http'
import{ResponseClient}from'../ResponseClient';
import { addCountery, Countery } from "./countery";
import{map}from 'rxjs/operators';
@Injectable({
  providedIn:'root'
})
export class counteryService{
/**
 *
 */
baseUrl:string='https://localhost:5001/api/System/'
constructor(private client:HttpClient){}
addcountery(countrey:addCountery){
  return this.client.post<ResponseClient>(this.baseUrl+'AddCountery',countrey).pipe(map(response=>{
    const country :ResponseClient=response;
    console.log(country)
    return country;
  }))
}
getCountery(){
  return this.client.get<ResponseClient>(this.baseUrl+'GetCounteries').pipe<ResponseClient>(map(Response=>{
    const country=Response;
    console.log(country)
    return country;
  }))
}
}
