import { HttpClient ,HttpParams} from "@angular/common/http";
import { Component, OnInit,ViewChild } from "@angular/core";
import { ResponseClient } from "../ResponseClient";
import { Countery } from "./countery";
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
@Component({
  selector:'countery-app',
  templateUrl:'./countery.component.html'
})
export class countercomponent implements OnInit
{
  public counteries:Countery[]=[];
  public counteries2:Countery[]=[];
  public displayedColumns: string[] = ['id', 'name'];
  defaultPageIndex: number = 0;
  defaultPageSize: number = 10;
  public defaultSortColumn: string = "name";
  public defaultSortOrder: string = "asc";
  defaultFilterColumn: string = "name";
  filterQuery: string ="";
  public counterymeta: MatTableDataSource<Countery>;
   @ViewChild(MatPaginator) paginator: MatPaginator
  constructor(private Http:HttpClient)
  {

  }
  ngOnInit(): void {
    console.log("hghh");
    this.Http.get<ResponseClient>('https://localhost:5001/'+'api/'+'System/GetCounteries').subscribe((reslt:ResponseClient )=>{
        this.counteries=(reslt.data as Countery[]);
        this.counterymeta = new MatTableDataSource<Countery>(this.counteries);
       this.counterymeta.paginator = this.paginator;
        console.log(reslt.message);
        console.log(reslt.status);
    },error=>{console.log(error)});

    }
    loadData(query: string ) {
      var pageEvent = new PageEvent();
      pageEvent.pageIndex = this.defaultPageIndex;
      pageEvent.pageSize = this.defaultPageSize;
      if (query) {
      this.filterQuery = query;
      }
     // this.getData(pageEvent);
      }
  //     getData(event: PageEvent) {
  //     var url = 'https://localhost:5001/'+'api/'+'System/GetCounteries';
  //     var params = new HttpParams()
  //     .set("pageIndex", event.pageIndex.toString())
  //     .set("pageSize", event.pageSize.toString())
  //     .set("sortColumn", (this.sort)
  //     ? this.sort.active
  //     : this.defaultSortColumn)
  //     .set("sortOrder", (this.sort)
  //     ? this.sort.direction
  //     : this.defaultSortOrder);
  //     if (this.filterQuery) {
  //     params = params
  //     .set("filterColumn", this.defaultFilterColumn)
  //     .set("filterQuery", this.filterQuery);
  //     }
  // }
}
