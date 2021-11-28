import { Component, OnInit } from "@angular/core";
import { addCity, updateCity,cityCountery,AddcityCountery } from "./city";
import { CityService } from "./CityS.service";
@Component({
  selector:'city-app',
  templateUrl:'./City.Component.html'
})
export class CityComponent implements OnInit{
 cities:cityCountery[]=[];
 updateCity!: cityCountery;
 constructor(private cityserv:CityService) {}
  ngOnInit(): void {
    this.getallCity();
  }
 getallCity(){
   this.cityserv.getCitiesService().subscribe(response=>{
     if(response.status)
      {
        const citiesc:cityCountery[]=response.data as cityCountery[];
        this.cities=citiesc;
      }
   },error=>{
     console.log(error);
   })
 }
 addCity(addcity:AddcityCountery){
   this.cities.unshift( {id:"fghffg",name:addcity.name,counteryId:"",countery:{id:addcity.countery.id,name:addcity.countery.name}});
   console.log(addcity);
}

Update(id:string)
{
  this.updateCity= this.cities.filter(d=>d.id==id)[0];
  console.log(this.updateCity)
}
}

