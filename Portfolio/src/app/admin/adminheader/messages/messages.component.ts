import { Component, Input, OnInit } from '@angular/core';
import { IMessage } from 'src/app/interfaces/imessage';

@Component({
  selector: 'app-messages',
  templateUrl: './messages.component.html',
  styleUrls: ['./messages.component.css']
})
export class MessagesComponent implements OnInit {

  @Input() unread: IMessage = {};

  constructor() { }

  ngOnInit(): void {
  }

}
