import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { IContact } from 'src/app/interfaces/icontact';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-profilecontact',
  templateUrl: './profilecontact.component.html',
  styleUrls: ['./profilecontact.component.css']
})
export class ProfilecontactComponent implements OnInit {

  contactForm = new FormGroup({
    phone: new FormControl(),
    email: new FormControl()
  });

  constructor(private api: ApiService) { }

  ngOnInit(): void {
  }

  contactHandler(contactObj: IContact) {
    console.log(contactObj);
    this.api.saveContact(contactObj).subscribe(data => console.log(data));
  }

}
