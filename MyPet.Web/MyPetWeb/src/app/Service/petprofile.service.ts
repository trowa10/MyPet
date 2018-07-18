import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class PetProfileService {
  
  private _apiUrl = 'http://localhost:54049/api';

  constructor(private http: HttpClient) { }

  getPetProfile() {

    return  this.http.get(`${this._apiUrl}/petprofile`);
  }
}
