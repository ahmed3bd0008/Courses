import { Component, OnInit } from "@angular/core";
import { ResponseClient } from "src/app/ResponseClient";
import { Countery } from "../countery";
import{counteryService}from"../countery.service";
import { Output, EventEmitter } from '@angular/core';
@Component({
  selector:"select-countery-app",
  templateUrl:'./select-countery.component.html'
})
export class selectcounterycomponent implements OnInit{
/**
 *
 */
 @Output() newItemEvent = new EventEmitter<Countery>();
constructor( private counteryserv: counteryService) {
}
selectedValue:string='';

  ngOnInit(): void {
    this.GetSelectCountery();
  }
counteryArr:Countery[]=[];
GetSelectCountery(){
  this.counteryserv.getCountery().subscribe((response:ResponseClient)=>{
    if(response.status)
    {
      this.counteryArr=response.data as Countery[]
    }
  },error=>{
    console.log(Error)
  })
}
addNewItem(value: Countery) {
if(value)
  this.newItemEvent.emit(value);
}
getSelect($event:any){

 const  name :string= $event.target.options[$event.target.options.selectedIndex].text;
 const id:string = $event.target.options[$event.target.options.selectedIndex].value;
 if(id || id.trim()!='')
 {
   const countery :Countery={id:id,name:name};
    this.addNewItem( countery)
 }
}
}
