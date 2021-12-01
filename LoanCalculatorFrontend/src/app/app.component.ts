import { Component } from '@angular/core';
import { Observable, Subscription } from 'rxjs';
import { HttpService } from './services/http/http.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  propertyValue = null;
  amount = null;
  title = 'loanCalculator';
  result = 0;
  calculator$: Subscription = new Subscription();

  constructor(private httpService: HttpService) {}

  calculate() {
    this.calculator$ = this.httpService
      .getRequest({
        url: 'Loan',
        body: {
          propertyValue: this.propertyValue,
          amount: this.amount,
        },
        token: '',
      })
      .subscribe(async (result: any) => {
        if (result?.data) {
          this.result = result.data.toFixed(3);
        }
      });
  }

  ngOnDestroy(): void {
    if (this.calculator$) {
      this.calculator$.unsubscribe();
    }
  }
}
