import { HttpClient ,HttpParams} from "@angular/common/http";
import { Component, OnInit,ViewChild } from "@angular/core";
import { ResponseClient } from "../ResponseClient";
import { Countery } from "./countery";
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatDialog } from "@angular/material/dialog";
import { addcounterycomponent } from "./add-countery/add-countery.component";
import { counteryService } from "./countery.service";
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
  name:string="";
  counterydalog!: Countery;
  public counterymeta!: MatTableDataSource<Countery>;
   @ViewChild(MatPaginator)
  paginator!: MatPaginator;
  constructor(private Http:HttpClient,private dailog:MatDialog,private CounterServ:counteryService)
  {

  }
  ngOnInit(): void {
    console.log("hghh");
   this.GetDataService();
   //this.getCounteryData()
    }

    getCounteryData(){
      this.Http.get<ResponseClient>('https://localhost:5001/'+'api/'+'System/GetCounteries').subscribe((reslt:ResponseClient )=>{
        this.counteries=(reslt.data as Countery[]);
        this.counterymeta = new MatTableDataSource<Countery>(this.counteries);
       this.counterymeta.paginator = this.paginator;
    },error=>{console.log(error)});
    }

    GetDataService(){
      this.CounterServ.getCountery().subscribe((reslt:ResponseClient )=>{
        this.counteries=(reslt.data as Countery[]);
        this.counterymeta = new MatTableDataSource<Countery>(this.counteries);
       this.counterymeta.paginator = this.paginator;
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
openDailog(){
let dailogRef= this.dailog.open(addcounterycomponent,{
  width:'700px',
  height:'500px',
  data: { countery: this.counterydalog },
  disableClose:true
})
dailogRef.afterClosed().subscribe(response=>{
  console.log(response.Data);
  this.counterydalog
  this.GetDataService()
});
}

}
