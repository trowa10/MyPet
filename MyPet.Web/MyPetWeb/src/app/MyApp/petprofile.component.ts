import { Component, OnInit } from '@angular/core';
import { PetProfileService } from '../Service/petprofile.service';
import { IPetProfileModel } from '../Model/IPetProfileModel';

@Component({
  selector: 'app-pet-profile',
  templateUrl: './petprofile.component.html',
  styleUrls: ['./petprofile.component.css']
})
export class PetProfileComponent implements OnInit {
    Pets: any = [];
    selectedPet: any;
    constructor(private readonly _service: PetProfileService) {

     }
    ngOnInit() {

        this._service.getPetProfile().subscribe(
            (data: IPetProfileModel) => this.Pets = data, // success path
            error => console.log(error) // error path
          );

       }

}
