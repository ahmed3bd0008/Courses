import { Component, Input, OnChanges, OnInit, SimpleChanges } from "@angular/core";
import{cityCountery}from "../city"
import { CityService } from "../CityS.service";
@Component({
  selector:'update-city-app',
  templateUrl:'./update-city.component.html'
})
export class updateCityComponent implements OnChanges{
  selectedCounteryId:string='';
  constructor(private cityserv:CityService){
    this.sendcity={name:'',id:'',counteryId:'',countery:{id:"",name:''}};;
  }
  ngOnChanges(changes: SimpleChanges): void {
    if(this.updateCityChild)
    {
      this.sendcity=this.updateCityChild;
      this.selectedCounteryId=this.sendcity.countery.id;

    }
  }
  update(){

  }
  sendcity :cityCountery;
  name:string="";
 @Input()updateCityChild :cityCountery={name:'',id:'',counteryId:'',countery:{id:"",name:''}};
}
