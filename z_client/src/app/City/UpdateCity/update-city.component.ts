import { Component, Input, OnChanges, OnInit, SimpleChanges, ViewChild } from "@angular/core";
import{cityCountery, updateCity}from "../city"
import { CityService } from "../CityS.service";
@Component({
  selector:'update-city-app',
  templateUrl:'./update-city.component.html'
})
export class updateCityComponent implements OnChanges{
  selectedCounteryId:string='';
  cityName:string='';
  @ViewChild('closeupdatebutton') closebutton:any;
  constructor(private cityserv:CityService){
    this.sendcity={name:'',id:'',counteryId:'',countery:{id:"",name:''}};;
  }
  ngOnChanges(changes: SimpleChanges): void {
    if(this.updateCityChild)
    {
      this.sendcity=this.updateCityChild;
      this.selectedCounteryId=this.sendcity.countery.id;
      this.cityName=this.updateCityChild.name;
    }
  }
  getSelectcoumtery(event:string){
    this.selectedCounteryId=event;
  }
  update(){
  const city:updateCity={id:this.sendcity.id,counteryId:this.selectedCounteryId,name:this.cityName}
    this.cityserv.updateCity(city).subscribe(
      response=>{
        console.log(response);
        if(response.status)
        {
          this.closebutton.nativeElement.click()
          this.sendcity.name=this.cityName;
        }
      },error=>{
        console.log(error)
      }
    )
    console.log(this.selectedCounteryId)
  }
  sendcity :cityCountery;
  name:string="";
 @Input()updateCityChild :cityCountery={name:'',id:'',counteryId:'',countery:{id:"",name:''}};
}
