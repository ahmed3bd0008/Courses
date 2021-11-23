import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { map } from "rxjs/operators";
import { addCity, city } from "./city";
import { ResponseClient } from "../ResponseClient";
@Injectable({
  providedIn:'root'
})
export class CityService{
baseUrl:string='https://localhost:5001/api/System/'
/**
 *
 */
constructor(private client:HttpClient) {

}

getCitiesService(){
  return this.client.get<ResponseClient>(this.baseUrl+'GetCities').
  pipe(map(
    response=>{
      const ServiceRepose:ResponseClient=response;
      return ServiceRepose;
    }
  ))
}

addCity(city:addCity){
  return this.client.post<ResponseClient>(this.baseUrl+'AddCity',city).
  pipe(map(
    response=>{
      const addresponse=response;
      return addresponse;
    }
  )

  )
}
}
