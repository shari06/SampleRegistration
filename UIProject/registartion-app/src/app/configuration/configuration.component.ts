import { Component, OnInit } from '@angular/core';
import {
  FormGroup,
  FormControl,
  FormBuilder,
  Validators,
} from '@angular/forms';
import { ConflgValues } from '../Models/ConfigValues';
import { ConfigApiService } from '../config-api.service';
import { Configuration } from '../Models/Configuration';

@Component({
  selector: 'app-configuration',
  templateUrl: './configuration.component.html',
  styleUrls: ['./configuration.component.css'],
})
export class ConfigurationComponent implements OnInit {
  configValues: ConflgValues[] = [];
  configuration: Configuration;

  fieldName = new FormControl('', [
    Validators.required,
    Validators.maxLength(15),
  ]);
  fieldType = new FormControl('', [
    Validators.required,
    Validators.maxLength(15),
  ]);
  fieldInfo = new FormControl('', [
    Validators.required,
    Validators.maxLength(15),
  ]);

  ddfieldType: any = ['Text', 'Number', 'DropDown', 'Email', 'Checkbox'];
  constructor(public fb: FormBuilder, private configApi: ConfigApiService) {}

  ngOnInit() {}

  onAdd() {
    if (
      this.fieldName !== null &&
      this.fieldType !== null &&
      this.fieldInfo !== null
    ) {
      this.configValues.push(
        new ConflgValues(
          this.fieldName.value,
          this.fieldType.value,
          this.fieldInfo.value
        )
      );
    }
    this.fieldName.reset();
    this.fieldType.reset();
    this.fieldInfo.reset();
  }

  onSave() {
    if (this.configValues.length > 0) {
      this.configuration = new Configuration(this.configValues);
      this.configApi.sendFormData(JSON.stringify(this.configuration)).subscribe(
        (response) => console.log('Success! ', response),
        (error) => console.error('Error: ', error)
      );
    }
  }
}
