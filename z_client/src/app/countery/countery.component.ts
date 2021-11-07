import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { ResponseClient } from "../ResponseClient";
import { Countery } from "./countery";
@Component({
  selector:'countery-app',
  templateUrl:'./countery.component.html'
})
export class countercomponent implements OnInit
{
  public counteries:Countery[]=[];
  public displayedColumns: string[] = ['id', 'name'];
  constructor(private Http:HttpClient)
  {

  }
  ngOnInit(): void {
    this.Http.get<ResponseClient>('https://localhost:5001/'+'api/'+'System/GetCounteries').subscribe((reslt:ResponseClient )=>{
        this.counteries=(reslt.data as Countery[]);
        console.log(reslt.message);
        console.log(reslt.status);
    },error=>{console.log(error)});

    }
  }

