import { Component, OnInit } from '@angular/core';
import { PetProfileService } from '../Service/petprofile.service';
import { IPetProfileModel } from '../Model/IPetProfileModel';
import {NgbModal, ModalDismissReasons} from '@ng-bootstrap/ng-bootstrap';
import { FileDropModule, UploadFile, UploadEvent } from 'ngx-file-drop';


@Component({
  selector: 'app-pet-profile',
  templateUrl: './petprofile.component.html',
  styleUrls: ['./petprofile.component.css']
})
export class PetProfileComponent implements OnInit {
    Pets: any = [];
    selectedPet: any;  
    files: UploadFile[] = [];
    modalTitle: string;
    modalMessage: string;

    constructor(private readonly _service: PetProfileService, private readonly _modalService: NgbModal) {

     }
    ngOnInit() {

        this._service.getPetProfile().subscribe(
            (data: IPetProfileModel) => this.Pets = data, // success path
            error => console.log(error) // error path
          );

       }

       public dropped(event: UploadEvent) {
        this.files = event.files;
    }

    saveFiles(content) {
      // tslint:disable-next-line:no-debugger
      debugger;
        if (this.selectedPet === undefined) {
            alert('Please select your pet');
        } else {
                if (this.files[0] === undefined) {
                    alert('Please select files to upload');
                } else {
                    this.modalTitle = 'Files uploaded';
                    let uploadedFiles = '';
                    let index = 0;
                    this.files.forEach(element => {
                        if (index > 0) {
                            if (index === this.files.length - 1) {
                                uploadedFiles += ' and ' + element.relativePath;
                            } else {
                                uploadedFiles += ', ' + element.relativePath;
                            }
                        } else {
                            uploadedFiles = element.relativePath;
                        }
                        index ++;
                    });
                    alert('Thank you for submitting ' + uploadedFiles + ' for ' + this.selectedPet);

                }
            }
    }

}
