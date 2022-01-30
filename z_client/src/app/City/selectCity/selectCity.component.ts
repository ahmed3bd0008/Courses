import { Component, Input, OnInit } from "@angular/core";
import { Countery } from "src/app/countery/countery";
import { city } from "../city";
import { CityService } from "../CityS.service";

@Component({
  selector:'select-city-app',
  templateUrl:'./selectCity.component.html',
  styleUrls:['./selectCity.component.css']
})
export class selectCityComponent implements OnInit
{
  counteryName?:string
  /**
   *
   */
   @Input() countery!:Countery
   @Input() selectcityId:string='';
   cityArr:city[]=[];
  constructor(private cityservice:CityService) {
  }
  ngOnInit(): void {
    if (this.countery) {
      this.loadDataById()
      this.loadDataByName()
      console.log(this.selectcityId)
      console.log(this.countery)
    }
  }
  loadDataById(){
    this.cityservice.getCounteryCitiesById(this.countery.id).subscribe(response=>{
      this.cityArr=response.data as city[];
    },error=>{
      console.log(error);

    }
    )
  }
  loadDataByName(){
    this.cityservice.getCounteryCitiesByName(this.countery.id).subscribe(response=>{
      this.cityArr=response.data as city[];
    },error=>{
      console.log(error);

    }
    )
  }
}
