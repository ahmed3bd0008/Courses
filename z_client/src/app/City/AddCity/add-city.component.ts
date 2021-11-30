import { Component, Input,Output,EventEmitter,ViewChild } from "@angular/core";
import{CityService}from"../CityS.service";
import{addCity,cityCountery,AddcityCountery}from "../city";
import { NgForm } from "@angular/forms";
import { Countery } from "src/app/countery/countery";
@Component({
  selector:'add-city-app',
  templateUrl:'./add-city.component.html'
})
export class addcitycomponent{
  cityName:string='';
  countery:Countery={id:"",name:""};
  @Output() addToCityListEvent = new EventEmitter<addCity>();
  @ViewChild('closebutton')closebutton:any;
  constructor(private cityServ:CityService){}
  onSubmit(){
    this.cityServ.addCity({name:this.cityName,counteryId:this.countery.id}).subscribe((Response)=>{
      {
        if(Response.status)
        {
          const  sendCity :AddcityCountery={
            name:this.cityName,
            counteryId:this.countery.id,
            countery:{
              name:this.countery.name,
              id:this.countery.id,
            }
          }

          this.addToEventList(sendCity);
          this.onSave();
          this.cityName='';
        }
      }
    },error=>{
      console.log(error)
    } )
    }
    submite(mod:NgForm)
    {
      this.cityServ.addCity({name:this.cityName,counteryId:this.countery.id}).subscribe((Response)=>{
        {
          if(Response.status)
          {

            const  sendCity :AddcityCountery={
              name:this.cityName,
              counteryId:this.countery.id,
              countery:{
                name:this.countery.name,
                id:this.countery.id,
              }
            }

            this.addToEventList(sendCity);
            this.onSave();
            this.cityName='';
            mod.resetForm();

          }
        }
      },error=>{
        console.log(error)
      } )
    }
    //methid fire from  select countery
  addItem(newItem: Countery) {
    this.countery =newItem;
  }
  addToEventList(city:addCity)
  {
    this.addToCityListEvent.emit(city);
  }
  public onSave() {
    this.closebutton.nativeElement.click();

  }
}
