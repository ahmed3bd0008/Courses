import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { map } from "rxjs/operators";
import { addCity, city,updateCity } from "./city";
import { ResponseClient } from "../ResponseClient";
import { environment } from "src/environments/environment";
@Injectable({
  providedIn:'root'
})
export class CityService{

//baseUrl:string='https://localhost:5001/api/System/'
baseUrl:string=environment.baseUrl+'/System/'
/**
 *
 */
constructor(private client:HttpClient) {

}

getCitiesService(){
  return this.client.get<ResponseClient>(this.baseUrl+'GetCitiesCounterfull').
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

updateCity(city: updateCity)
{
  return this.client.put<ResponseClient>(this.baseUrl+'UpdateCity',city).pipe(
    map(Response=>{
      const updateresponse:ResponseClient=Response;
      return updateresponse;
    })
  )
}


deleteCity(cityId:string)
{
  return this.client.delete<ResponseClient>(this.baseUrl+'DeleteCity?DeleteId='+cityId).pipe(
    map(Response=>{
      const updateresponse:ResponseClient=Response;
      return updateresponse;
    })
  )
}
getCounteryCitiesByName(counteryName :string ){
  return this.client.get<ResponseClient>(this.baseUrl+'GetCitiesByCounteryName/'+counteryName).
  pipe(map(Response=>{
    const responses:ResponseClient=Response;
    return responses;
  }))
}
getCounteryCitiesById(counteryId:string)
{
  return this.client.get<ResponseClient>(this.baseUrl+'GetCitiesByCounteryId?counteryId='+counteryId).
  pipe(map(Response=>{
    const responses:ResponseClient=Response;
    return responses;
  }))
}
}
