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
}

Update(id:string)
{
  this.updateCity= this.cities.filter(d=>d.id==id)[0];
}
Delete(id:string)
{
  this.cityserv.deleteCity(id).subscribe(
    Response=>{
      if(Response.status)
      {
        this.getallCity();
      }
      console.log(Response);
    },error=>{
      console.log(error);

    }

  )
}
}

