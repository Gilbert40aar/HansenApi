import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ILocation } from 'src/app/interfaces/ilocation';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-profilelocation',
  templateUrl: './profilelocation.component.html',
  styleUrls: ['./profilelocation.component.css']
})
export class ProfilelocationComponent implements OnInit {

  locationForm = new FormGroup({
    addRess: new FormControl(),
    zipCode: new FormControl(),
    city: new FormControl(),
    country: new FormControl()
  });

  constructor(private api: ApiService) { }

  ngOnInit(): void {
  }

  locationHandler(locationObj: ILocation) {
    console.log(locationObj);
    this.api.saveLocation(locationObj).subscribe(data => console.log(data));
  }

}
