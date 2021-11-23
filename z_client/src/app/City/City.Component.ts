import { Component, OnInit } from "@angular/core";
import { addCity, city } from "./city";
import { CityService } from "./CityS.service";
@Component({
  selector:'city-app',
  templateUrl:'./City.Component.html'
})
export class CityComponent implements OnInit{
 cities:city[]=[];
 constructor(private cityserv:CityService) {}
  ngOnInit(): void {
    this.getallCity();
  }
 getallCity(){
   this.cityserv.getCitiesService().subscribe(response=>{
     if(response.status)
      {
        const citiesc:city[]=response.data as city[];
        this.cities=citiesc;
      }
   },error=>{
     console.log(error);
   })
 }
 addCity(addcity:addCity){
   this.cities.unshift( {id:"fghffg",name:addcity.name});
   console.log(addcity);
}
opendailogFun(){
}
}
