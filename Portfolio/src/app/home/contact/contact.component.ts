import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {

  contactForm = new FormGroup({
    fullName: new FormControl(),
    email: new FormControl(),
    subject: new FormControl(),
    message: new FormControl()
  });

  constructor() { }

  ngOnInit(): void {
  }

}
