import { Component, OnInit } from "@angular/core";
import{courselevelservice}from"../courseLevel/courselevel.service";
import { HttpClient } from "@angular/common/http";
import { CourseLevel } from "./Course-level";
import { ResponseClient } from "../../ResponseClient";
@Component({
  selector:'coursLevel-app',
  template:'<select class="form-select" aria-label="Default select example">'+
  '<option selected>Open this select menu</option>'+
  '<option value="1">One</option>'+
  '<option value="2">Two</option>'+
  '<option value="3">Three</option>'+
'</select>'
})
export class courselevelcomponent implements OnInit
{
    constructor(private CourseLevelServ: courselevelservice ,private client:HttpClient){

    }
  ngOnInit(): void {
    
  }

}
