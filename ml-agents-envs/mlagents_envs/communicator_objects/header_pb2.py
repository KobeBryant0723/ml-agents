# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: mlagents_envs/communicator_objects/header.proto

from google.protobuf import descriptor as _descriptor
from google.protobuf import message as _message
from google.protobuf import reflection as _reflection
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()




DESCRIPTOR = _descriptor.FileDescriptor(
  name='mlagents_envs/communicator_objects/header.proto',
  package='communicator_objects',
  syntax='proto3',
  serialized_options=b'\252\002\034MLAgents.CommunicatorObjects',
  serialized_pb=b'\n/mlagents_envs/communicator_objects/header.proto\x12\x14\x63ommunicator_objects\".\n\x0bHeaderProto\x12\x0e\n\x06status\x18\x01 \x01(\x05\x12\x0f\n\x07message\x18\x02 \x01(\tB\x1f\xaa\x02\x1cMLAgents.CommunicatorObjectsb\x06proto3'
)




_HEADERPROTO = _descriptor.Descriptor(
  name='HeaderProto',
  full_name='communicator_objects.HeaderProto',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='status', full_name='communicator_objects.HeaderProto.status', index=0,
      number=1, type=5, cpp_type=1, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='message', full_name='communicator_objects.HeaderProto.message', index=1,
      number=2, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=b"".decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=73,
  serialized_end=119,
)

DESCRIPTOR.message_types_by_name['HeaderProto'] = _HEADERPROTO
_sym_db.RegisterFileDescriptor(DESCRIPTOR)

HeaderProto = _reflection.GeneratedProtocolMessageType('HeaderProto', (_message.Message,), {
  'DESCRIPTOR' : _HEADERPROTO,
  '__module__' : 'mlagents_envs.communicator_objects.header_pb2'
  # @@protoc_insertion_point(class_scope:communicator_objects.HeaderProto)
  })
_sym_db.RegisterMessage(HeaderProto)


DESCRIPTOR._options = None
# @@protoc_insertion_point(module_scope)
