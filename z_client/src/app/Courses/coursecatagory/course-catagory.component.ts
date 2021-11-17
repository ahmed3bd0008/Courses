import { Component, OnInit } from "@angular/core";
import{coursecatagoryservice}from"../coursecatagory/course-catagory.service";
import{ResponseClient}from"../../ResponseClient";
import{CourseCategory}from "../coursecatagory/category";

@Component({
  selector:'coursCatagory-app',
  template:'<select class="form-select" aria-label="Default select example">'+
  '<option selected>Open this select menu</option>'+
  '<option value="1">One</option>'+
  '<option value="2">Two</option>'+
  '<option value="3">Three</option>'+
'</select>'
})
 export class coursecatagorycomponent
 {
//    CourseCategories:CourseCategory[]=[];
//   constructor(private catagoryService: coursecatagoryservice) {
//   }
//   getCourseCatagory(){
//     this.catagoryService.getCategory()
//       .subscribe(arg=>
//         {
//             const categories:ResponseClient=arg;
//             this.CourseCategories=categories.data as CourseCategory[];
//         });
//   }
//   ngOnInit(): void {
//     this.getCourseCatagory()
//   }
}
