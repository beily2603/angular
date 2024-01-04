import { Injectable } from '@angular/core';
import {HttpClient, HttpParams} from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Service } from '../Classes/service';
import { Response } from '../Classes/response';

@Injectable({
  providedIn: 'root'
  
})
export class HttpService {
  URL='https://localhost:44300/api';
  constructor(private http: HttpClient) { }

  getAllServices():Observable<Service[]>{
    return this.http.get<Service[]>(this.URL+"/service");
  }
  getAllResponses():Observable<Response[]>{
    return this.http.get<Response[]>(this.URL+"/Feedback");
  }
  addResponse(response:Response):Observable<Response[]>{
    console.log(response);
    return this.http.post<Response[]>(this.URL+"/Response",response);
  }
  updateResponse(response:Response):Observable<Response[]>{
    return this.http.put<Response[]>(this.URL+"/Response",response);
  }
}
