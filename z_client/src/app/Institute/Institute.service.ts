import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
import { Email } from './model/email';
import { Phone } from './model/phone';
import { Website } from './model/website';
@Injectable({
  providedIn: 'root'
})
export class InstituteService {
emailEvent=new Subject<Email[]>();
phoneEvent=new Subject<Phone[]>();
websiteEvent=new Subject<Website[]>();
describeEvent=new Subject<string>();
constructor() { }
}
