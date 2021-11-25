import { Component, Input,Output,EventEmitter,ViewChild } from "@angular/core";
import{CityService}from"../CityS.service";
import{addCity}from "../city";
import { NgForm } from "@angular/forms";
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
  onSubmit(createCity:NgForm){
    this.cityServ.addCity({name:this.cityName,counteryId:this.counteryId}).subscribe((Response)=>{
      {
        if(Response.status)
        {
          this.sendCity.counteryId=this.counteryId;
          this.sendCity.name=this.cityName;
          this.addToEventList(this.sendCity);
          this.onSave(createCity);
          this.cityName='';
          createCity.reset();
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
  public onSave(city:NgForm) {
    console.log(city.value);
    this.closebutton.nativeElement.click();

  }
}
