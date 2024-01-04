import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'quotationMarks'
})
export class QuotationMarksPipe implements PipeTransform {

  transform(value?: string): unknown {
    return  `"${value}"`;
  
  }
 
}
