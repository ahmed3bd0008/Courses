import { Component, Input,Output,EventEmitter,ViewChild, ElementRef } from "@angular/core";
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
  @ViewChild('closebutton')
  closebutton!: ElementRef;
  constructor(private cityServ:CityService){}
  onSubmit(){
    if(this.cityName || !this.cityName.trim())
    {
      this.cityServ.addCity({name:this.cityName,counteryId:this.counteryId}).subscribe((Response)=>{
        {
          console.log(Response.status)
          if(Response.status)
          {
            this.sendCity.counteryId=this.counteryId;
            this.sendCity.name=this.cityName;
            this.addToEventList(this.sendCity);
            this.onSave();
            this.cityName='';

          }
        }
      },error=>{
        console.log(error)
      } )
    }
    else{
      console.log("name is nulls")
    }
    }
  addItem(newItem: string) {
    this.counteryId=newItem;
  }
  addToEventList(city:addCity)
  {
    this.addToCityListEvent.emit(city);
  }
  public onSave() {
    console.log("hhhhhh");
    this.closebutton.nativeElement.click();

  }
}
