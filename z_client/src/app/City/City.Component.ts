import { Component, OnInit } from "@angular/core";
import { city } from "./city";
import { CityService } from "./CityS.service";
@Component({
  selector:'city-app',
  templateUrl:'./City.Component.html'
})
export class CityComponent implements OnInit{
 /**
  *
  */
 cities:city[]=[];
 constructor(private cityserv:CityService) {}
  ngOnInit(): void {
    this.getallCity();
  }
 getallCity(){
   this.cityserv.getCitiesService().subscribe(response=>{
     console.log(response)
     if(response.status)
      {
        const citiesc:city[]=response.data as city[];
        this.cities=citiesc;
      }
   },error=>{
     console.log(error);
   })
 }
}
