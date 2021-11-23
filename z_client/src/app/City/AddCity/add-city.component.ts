import { Component } from "@angular/core";
import { NgForm } from "@angular/forms";
import{CityService}from"../CityS.service"
import{addCity}from "../city"
import { error } from "@angular/compiler/src/util";
@Component({
  selector:'add-city-app',
  templateUrl:'./add-city.component.html'
})

export class addcitycomponent{
  cityName:string='';
  counteryId:string='';
  constructor(private cityServ:CityService){}
  onSubmit(){

    console.log({name:this.cityName,counteryId:this.counteryId})
    this.cityServ.addCity({name:this.cityName,counteryId:this.counteryId}).subscribe(Response=>{

      console.log(Response);
    },error=>{
      console.log(error)
    } )
    }


  addItem(newItem: string) {
    this.counteryId=newItem;
  }
}
