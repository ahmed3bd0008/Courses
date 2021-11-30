import { Component, Input, OnChanges, OnInit, SimpleChanges } from "@angular/core";
import { ResponseClient } from "src/app/ResponseClient";
import { Countery } from "../countery";
import{counteryService}from"../countery.service";
import { Output, EventEmitter } from '@angular/core';
@Component({
  selector:"select-countery-app",
  templateUrl:'./select-countery.component.html'
})
export class selectcounterycomponent implements OnInit,OnChanges{
 @Output() newItemEvent = new EventEmitter<Countery>();
 //ForUpdate
 @Input()selectCountery:string="";
//use For update
 @Output() counterId=new EventEmitter<string>();
constructor( private counteryserv: counteryService) {
}
  ngOnChanges(changes: SimpleChanges): void {
     console.log(this.selectCountery);
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
//get Value of Text Select Of counter Name Id
 const  name :string= $event.target.options[$event.target.options.selectedIndex].text;
 const id:string = $event.target.options[$event.target.options.selectedIndex].value;
 if(id || id.trim()!='')
 {
   const countery :Countery={id:id,name:name};
    this.addNewItem( countery)
    this.counterId.emit(id);
 }
}
getCounterIdForUpdate( value:string){
  this.counterId.emit(value);
}
}
