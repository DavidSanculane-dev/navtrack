/**
 * Generated by orval v6.11.1 🍺
 * Do not edit manually.
 * Navtrack.Api, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
 * OpenAPI spec version: 1.0
 */
import type { ProtocolModel } from './protocolModel';

export interface DeviceTypeModel {
  id: string;
  manufacturer: string;
  model: string;
  readonly displayName: string;
  protocol: ProtocolModel;
}
