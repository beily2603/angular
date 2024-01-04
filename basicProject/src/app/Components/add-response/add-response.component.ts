import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { Response } from 'src/app/Classes/response';
import { GiftService } from 'src/app/Services/gift.service';
import { HttpService } from 'src/app/Services/http.service';

@Component({
  selector: 'app-add-response',
  templateUrl: './add-response.component.html',
  styleUrls: ['./add-response.component.scss']
})
export class AddResponseComponent implements OnInit, OnDestroy {

  addResponseForm: FormGroup = new FormGroup({});
  response: Response = {};


  subscription: Subscription = new Subscription();

  constructor(public httpService: HttpService, public giftSer: GiftService) {
    giftSer.getEntitlement().subscribe((d) => console.log(d));
  }

  ngOnDestroy(): void {
    this.subscription.unsubscribe;
  }


  ngOnInit(): void {
    this.addResponseForm = new FormGroup({
      firstName: new FormControl('', [Validators.required, Validators.minLength(2)]),
      lastName: new FormControl('', [Validators.required, Validators.minLength(2)]),
      description: new FormControl('', [Validators.required]),
      phoneNumber: new FormControl('', [Validators.required]),
      Email: new FormControl('', [Validators.required]),
      likes: new FormControl(1)
    })

  }
  addResponse() {
    this.response = this.addResponseForm?.value;
    this.subscription = this.httpService.addResponse(this.response).subscribe((data) => {
      console.log('data', data);
    }, (err) => {
      console.log(err);
    })
    console.log(this.giftSer.getEntitlement());

    //  this.giftSer.entitlement$.next(!this.giftSer.entitlement$);
    this.giftSer.updateEntitlement()
    console.log(this.giftSer.getEntitlement());
  }
  subject() {
    this.giftSer.updateEntitlement()

  }
}
