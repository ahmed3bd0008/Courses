import { Component, Input,Output,EventEmitter,ViewChild } from "@angular/core";
import{CityService}from"../CityS.service";
import{addCity}from "../city";
@Component({
  selector:'add-city-app',
  templateUrl:'./add-city.component.html'
})

export class addcitycomponent{
  cityName:string='';
  counteryId:string='';
  @Output() addToCityListEvent = new EventEmitter<addCity>();
  sendCity:addCity={name:'',counteryId:''};
  @ViewChild('closebutton')closebutton:any;
  constructor(private cityServ:CityService){}
  onSubmit(){
    this.cityServ.addCity({name:this.cityName,counteryId:this.counteryId}).subscribe((Response)=>{
      {
        if(Response.status)
        {
          this.sendCity.counteryId=this.counteryId;
          this.sendCity.name=this.cityName;
          this.addToEventList(this.sendCity);
          this.closebutton.nativeElement.click();

        }
      }
    },error=>{
      console.log(error)
    } )
    }
  addItem(newItem: string) {
    this.counteryId=newItem;
  }

  addToEventList(city:addCity)
  {
    this.addToCityListEvent.emit(city);
  }
  public onSave() {
    this.closebutton.nativeElement.click();
  }
}
